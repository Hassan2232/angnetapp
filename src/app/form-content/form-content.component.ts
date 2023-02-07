import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators, FormBuilder } from '@angular/forms';

import { ClientMessage } from 'src/Models/ClientMessage';
import { DataService } from '../data.service';
import {Router} from '@angular/router';

@Component({
  selector: 'app-form-content',
  templateUrl: './form-content.component.html',
  styleUrls: ['./form-content.component.css'],
  providers: [DataService],
})
export class FormContentComponent implements OnInit {
  protected aFormGroup!: FormGroup;
  
  constructor(
    private dataService: DataService, 
    private router: Router,
    private formBuilder: FormBuilder,
  ) { }

  ngOnInit() {
    this.aFormGroup = this.formBuilder.group({
      recaptcha: ['', Validators.required]
    });
  }

  siteKey: string = "6LcdZlskAAAAAKQGYOa43IYg0sXas0g8RdD0cMq3";

  submitFlag : boolean = false;
  recaptchaSubmitFlag: boolean = false;

  clientInfo: ClientMessage = new ClientMessage();
  clientsInfo: ClientMessage[] = [];

  data = new FormGroup( {
    userName: new FormControl<string>('', [
      Validators.required,
    ]),
    userEmail: new FormControl<string>('', [
      Validators.required,
      Validators.email,
    ]),
    userPhone: new FormControl<string>('', [
      Validators.required,
    ]),
    userTheme: new FormControl<string>('', [
      Validators.required,
    ]),
    userMessage: new FormControl<string>('', [
      Validators.required,
    ]),
  } )

  recaptchaSub() {
    this.recaptchaSubmitFlag = true;
  }

  submitData() {
    this.submitFlag = this.exceptionsForm();

    console.log(this.submitFlag);
    console.log("rec::", this.recaptchaSubmitFlag);
    
    if(!this.submitFlag && this.recaptchaSubmitFlag) {
      this.clientInfo.userName = "" + this.data.controls.userName.value;
      this.clientInfo.userEmaile = "" + this.data.controls.userEmail.value;
      this.clientInfo.userPhone = "" + this.data.controls.userPhone.value;
      this.clientInfo.userTheme = "" + this.data.controls.userTheme.value;
      this.clientInfo.userMessage = "" + this.data.controls.userMessage.value;

      this.dataService.createClient(this.clientInfo)
        .subscribe((data: ClientMessage) => { 
          this.clientsInfo.push(data);
          this.router.navigate(['output']);
        });
    }
  }

  exceptionsForm(): boolean {
    var flag = false;

    Object.values(this.data.controls).forEach(value => {
      if(value.errors) {
        flag = true;
      }
    });

    return flag;
  }
}
