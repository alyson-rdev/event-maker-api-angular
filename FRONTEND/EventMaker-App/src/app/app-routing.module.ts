import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EventosComponent } from './components/eventos/eventos.component';
import { HomeComponent } from './components/home/home.component';
import { ContatosComponent } from './components/contatos/contatos.component';

const routes: Routes = [
  { path: 'home', component: HomeComponent },
  { path: 'eventos', component: EventosComponent},
  { path: 'contatos', component: ContatosComponent},
  { path: '', redirectTo: 'home', pathMatch: 'full' },
  { path: '**', redirectTo: 'home', pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
