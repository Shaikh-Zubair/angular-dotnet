import { Models } from "./models";
export class Makes {
  public id: number;
  public name: string;
  public models: Array<Models>;
  constructor() {
    this.id = 0;
    this.name = "";
    this.models = [new Models()];
  }
}
