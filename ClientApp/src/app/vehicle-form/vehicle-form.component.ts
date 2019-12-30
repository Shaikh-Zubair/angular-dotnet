import { Models } from "./../responseModels/models";
import { Makes } from "./../responseModels/makes";
import { MakeService } from "./../services/make.service";
import { Component, OnInit } from "@angular/core";
import { FormGroup, FormBuilder, Validators } from "@angular/forms";

@Component({
  selector: "app-vehicle-form",
  templateUrl: "./vehicle-form.component.html",
  styleUrls: ["./vehicle-form.component.css"]
})
export class VehicleFormComponent implements OnInit {
  public makes: Array<Makes> = [];
  public selectedMake: Makes;
  newVehicle: FormGroup;

  constructor(private makeService: MakeService, private fb: FormBuilder) {}

  ngOnInit() {
    this.initForm();
    this.getMakes();
  }

  initForm() {
    this.newVehicle = this.fb.group({
      make: [null, Validators.required],
      model: [null, Validators.required],
      features: [null, Validators.required]
    });
    this.newVehicle.controls.model.disable();
  }

  onChange() {
    this.newVehicle.controls.model.enable();
    this.selectedMake = this.makes.filter(
      val => val.id == this.newVehicle.value.make
    )[0];
    console.log(this.selectedMake);
  }

  getMakes() {
    this.makeService.getMakes().subscribe(res => {
      console.log(res);
      this.makes = res.slice();
    });
  }
}
