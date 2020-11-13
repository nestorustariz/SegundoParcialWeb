import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PersonaRegisterComponent } from './ParcialDos/persona-register/persona-register.component';
import { PersonaConsultaComponent } from './ParcialDos/persona-consulta/persona-consulta.component';
import {RouterModule, Routes} from '@angular/router';


const routes: Routes = [
  {
    path: 'personaRegistro',
    component:PersonaRegisterComponent
  },
  {
    path: 'personaConsulta',
    component:PersonaConsultaComponent
  }
];



@NgModule({
  declarations: [],
  imports: [
  CommonModule,
  RouterModule.forRoot(routes)
  ],
  exports:[RouterModule]
})
export class AppRoutingModule { }
