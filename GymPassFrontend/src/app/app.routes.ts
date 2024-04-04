import { Routes } from '@angular/router';
import { LoginComponent } from './pages/login/login.component';
import { RegistrationComponent } from './pages/registration/registration.component';
import { HomeComponent } from './pages/home/home.component';
import { ShopComponent } from './pages/shop/shop.component';
import { PassesComponent } from './pages/passes/passes.component';
import { ActivitiesComponent } from './pages/activities/activities.component';
import { AccountComponent } from './pages/account/account.component';

export const routes: Routes = [
  { path: '', component: LoginComponent },
  { path: 'register', component: RegistrationComponent },
  { path: 'home', component: HomeComponent },
  { path: 'shop', component: ShopComponent },
  { path: 'passes', component: PassesComponent },
  { path: 'activities', component: ActivitiesComponent },
  { path: 'account', component: AccountComponent },
];
