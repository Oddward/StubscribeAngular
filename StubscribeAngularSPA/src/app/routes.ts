import { SubscriptionComponent } from './views/subscription/subscription.component';
import { WelcomeComponent } from './views/welcome/welcome.component';
import { SettingsComponent } from './settings/settings.component';
import { Routes } from '@angular/router';

export const appRoutes: Routes = [
    {path: 'welcome', component: WelcomeComponent},
    {path: 'settings', component: SettingsComponent},
    {path: 'subscription', component: SubscriptionComponent},
    {path: '**', redirectTo: 'welcome', pathMatch: 'full'} // wildcard, redirect to safety, put last
]
