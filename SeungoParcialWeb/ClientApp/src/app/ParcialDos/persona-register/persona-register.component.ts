import { Component, OnInit } from '@angular/core';
import { Persona } from 'src/app/models/persona';
import {PersonaService} from 'src/app/services/persona.service';
@Component({
  selector: 'app-persona-register',
  templateUrl: './persona-register.component.html',
  styleUrls: ['./persona-register.component.css']
})
export class PersonaRegisterComponent implements OnInit {

  persona:Persona;
  constructor(private service:PersonaService) { }

  ngOnInit(): void {
    this.persona = new Persona;
  }





  get(){
    this.service.buscarIdentificacion(this.persona.identificacion).subscribe(result => {
      this.persona = result;
    });
  }
}
