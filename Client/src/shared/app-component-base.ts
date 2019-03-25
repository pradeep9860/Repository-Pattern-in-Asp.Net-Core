import { Injector, ElementRef } from "@angular/core";

export abstract class AppComponentBase {
  isLoading: boolean = false;
  elementRef: ElementRef;
  // dialog: MatDialog;

  constructor(injector: Injector) {
    this.elementRef = injector.get(ElementRef);
    // this.dialog = injector.get(MatDialog);
  }
}
