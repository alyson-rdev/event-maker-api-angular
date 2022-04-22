import { NgModule, Component } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http'

import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { CollapseModule } from 'ngx-bootstrap/collapse';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';
import { ModalModule } from 'ngx-bootstrap/modal';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavComponent } from './shared/nav/nav.component';
import { EventosComponent } from './components/eventos/eventos.component';
import { HomeComponent } from './components/home/home.component';
import { TituloComponent } from './shared/titulo/titulo.component';
import { ContatosComponent } from './components/contatos/contatos.component';
import { TooltipModule } from 'ngx-bootstrap/tooltip';
import { PerfilComponent } from './components/user/perfil/perfil.component';
import { PalestrantesComponent } from './components/palestrantes/palestrantes.component';
import { EventoService } from './services/evento.service';
import { EventoDetalheComponent } from './components/eventos/evento-detalhe/evento-detalhe.component';
import { EventoListaComponent } from './components/eventos/evento-lista/evento-lista.component';
import { UserComponent } from './components/user/user.component';
import { LoginComponent } from './components/user/login/login.component';
import { RegistrationComponent } from './components/user/login/registration/registration.component';


@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    EventosComponent,
    HomeComponent,
    TituloComponent,
    ContatosComponent,
    PerfilComponent,
    PalestrantesComponent,
    EventoDetalheComponent,
    EventoListaComponent,
    UserComponent,
    LoginComponent,
    RegistrationComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    CollapseModule.forRoot(),
    BsDropdownModule.forRoot(),
    ModalModule.forRoot(),
    ToastrModule.forRoot(
      {
        timeOut: 5000,
        positionClass: 'toast-bottom-right',
        preventDuplicates: true,
      }
    ),
    FormsModule,
    TooltipModule.forRoot()

  ],
  providers: [EventoService],
  bootstrap: [AppComponent]
})
export class AppModule { }
