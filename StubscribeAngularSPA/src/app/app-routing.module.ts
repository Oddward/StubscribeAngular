import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { WelcomeComponent } from './views/welcome/welcome.component';
import { SettingsComponent } from './settings/settings.component';
import { SubscriptionComponent } from './views/subscription/subscription.component';


const routes: Routes = [
  {path: 'welcome', component: WelcomeComponent},
  {path: 'settings', component: SettingsComponent},
  {path: 'subscription', component: SubscriptionComponent},
  {path: '**', redirectTo: 'welcome', pathMatch: 'full'} // wildcard, redirect to safety, put last
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
