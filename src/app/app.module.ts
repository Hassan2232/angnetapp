import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { FormComponent } from './form/form.component';
import { FormContentComponent } from './form-content/form-content.component';
import { OutputDataComponent } from './output-data/output-data.component';

import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { Routes, RouterModule } from '@angular/router';

import { NgxMaskModule, IConfig } from 'ngx-mask';
import { NgxCaptchaModule } from 'ngx-captcha';

const appRoutes: Routes = [
  {path: '', component: FormContentComponent},
  {path: 'output', component: OutputDataComponent}
]

@NgModule({
  declarations: [
    AppComponent,
    FormComponent,
    FormContentComponent,
    OutputDataComponent,
  ],
  imports: [
    BrowserModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    NgxMaskModule.forRoot(),
    RouterModule.forRoot(appRoutes),
    NgxCaptchaModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
