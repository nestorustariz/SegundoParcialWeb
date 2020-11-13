import { Component, OnInit } from '@angular/core';
import { Vacunacion } from 'src/app/models/vacunacions';
import { VacunacionService } from 'src/app/services/vacunacion.service';

@Component({
  selector: 'app-persona-consulta',
  templateUrl: './persona-consulta.component.html',
  styleUrls: ['./persona-consulta.component.css']
})
export class PersonaConsultaComponent implements OnInit {
 
  vacunas:Vacunacion[];
  Total :Number = 0;
  searchText = "";
  searchText1 = "";
  constructor(private service:VacunacionService) { }
 
  ngOnInit(): void {
    this.get();
  }
  get(){
    this.service.Consultar().subscribe(result => {
      this.vacunas = result;
    });
  }
}
