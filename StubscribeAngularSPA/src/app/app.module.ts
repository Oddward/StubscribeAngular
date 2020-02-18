import { MatSliderModule } from '@angular/material/slider';
import * as list from '@angular/material/list';
import { MatCardModule } from '@angular/material/card';
import { MatMenuModule } from '@angular/material/menu';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatSelectModule } from '@angular/material/select';
import { MatDialogModule } from '@angular/material/dialog';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome';

import { BrowserModule } from '@angular/platform-browser';
import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { HttpClientModule } from '@angular/common/Http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ValueComponent } from './value/value.component';
import { LayoutModule } from '@angular/cdk/layout';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatButtonModule } from '@angular/material/button';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatIconModule } from '@angular/material/icon';
import { NavComponent } from './nav/nav.component';
import { SubscriptionComponent } from './views/subscription/subscription.component';
import { MemberComponent } from './components/member/member.component';
import { SubsListComponent } from './subs-list/subs-list.component';
import { MembersListComponent } from './members-list/members-list.component';
import { SettingsComponent } from './settings/settings.component';
import { WelcomeComponent } from './views/welcome/welcome.component';
import { SubButtonComponent } from './components/sub-button/sub-button.component';
import { NewSubButtonComponent } from './components/new-sub-button/new-sub-button.component';
import { NewSubFormComponent } from './views/welcome/new-sub-form/new-sub-form.component';
import { MatNativeDateModule } from '@angular/material/core';

@NgModule({
  declarations: [
    AppComponent,
    ValueComponent,
    NavComponent,
    SubscriptionComponent,
    MemberComponent,
    SubsListComponent,
    MembersListComponent,
    SettingsComponent,
    WelcomeComponent,
    SubButtonComponent,
    NewSubButtonComponent,
    NewSubFormComponent,
  ],
  entryComponents: [
    NewSubFormComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    FontAwesomeModule,
    MatSliderModule,
    list.MatListModule,
    MatCardModule,
    HttpClientModule,
    LayoutModule,
    MatToolbarModule,
    MatButtonModule,
    MatSidenavModule,
    MatIconModule,
    MatMenuModule,
    MatFormFieldModule,
    MatSelectModule,
    MatDialogModule,
    MatDatepickerModule,
    MatNativeDateModule,
  ],
  providers: [
  ],
  bootstrap: [AppComponent],
  schemas: [
    CUSTOM_ELEMENTS_SCHEMA
  ]
})
export class AppModule { }
