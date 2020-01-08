import { Features } from "./../responseModels/Features";
import { Models } from "./../responseModels/models";
import { Makes } from "./../responseModels/makes";
import { VehicleService } from "../services/vehicle.service";
import { Component, OnInit } from "@angular/core";
import { FormGroup, FormBuilder, Validators } from "@angular/forms";

@Component({
  selector: "app-vehicle-form",
  templateUrl: "./vehicle-form.component.html",
  styleUrls: ["./vehicle-form.component.css"]
})
export class VehicleFormComponent implements OnInit {
  public makes: Array<Makes> = [];
  public selectedMake: Makes = new Makes();
  newVehicle: FormGroup;
  public features: Array<Features> = [];
  public selectedFeatures: Array<any> = [];

  constructor(
    private vehicleService: VehicleService,
    private fb: FormBuilder
  ) {}

  ngOnInit() {
    this.initForm();
    this.getMakes();
    this.getFeatures();
  }

  onSubmit(value: any) {
    const data = { ...value, features: this.selectedFeatures };
    console.log(data);
  }

  initForm() {
    this.newVehicle = this.fb.group({
      make: [null, Validators.required],
      model: [null, Validators.required],
      features: [],
      name: ["", Validators.required],
      phone: ["", Validators.required],
      email: ["", Validators.required],
      registered: [false, Validators.required]
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
    this.vehicleService.getMakes().subscribe(res => {
      console.log(res);
      this.makes = res.slice();
    });
  }

  getFeatures() {
    this.vehicleService.getFeatures().subscribe(res => {
      console.log(res);
      this.features = [...res];
    });
  }

  onFeatureSelect(feature: Features, event: any) {
    const checked = event.target.checked;
    if (
      !!!this.selectedFeatures.filter(x => x.id === feature.id).length &&
      checked
    ) {
      this.selectedFeatures.push(feature);
    } else {
      const index = this.selectedFeatures.findIndex(x => x.id === feature.id);
      this.selectedFeatures.splice(index, 1);
    }
  }
}
