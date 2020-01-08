import { Features } from "../responseModels/Features";
import { Makes } from "../responseModels/makes";
import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";

@Injectable({
  providedIn: "root"
})
export class VehicleService {
  constructor(private http: HttpClient) {}

  getMakes() {
    return this.http.get<Array<Makes>>("/api/makes");
  }

  getFeatures() {
    return this.http.get<Array<Features>>("/api/features");
  }
}
