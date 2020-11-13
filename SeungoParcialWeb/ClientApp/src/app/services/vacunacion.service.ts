import { HttpClient } from '@angular/common/http';
import { Injectable,Inject} from '@angular/core';
import { inject } from '@angular/core/testing';
import { Observable } from 'rxjs';
import { tap, catchError } from 'rxjs/operators';
import { HandleHttpErrorService } from '../@base/handle-http-error.service';
import { Vacunacion } from '../models/vacunacions';
 
@Injectable({
  providedIn: 'root'
})
export class VacunacionService {
  baseUrl: string;
 
  constructor(private http:HttpClient,@Inject('BASE_URL') baseUrl: string,private handleErrorService:HandleHttpErrorService) { this.baseUrl = baseUrl}
 
  Consultar(): Observable<Vacunacion[]>{
    return this.http.get<Vacunacion[]>(this.baseUrl + 'api/Vacunacion')
    .pipe(
        tap(_ => this.handleErrorService.log('Datos enviados')),
        catchError(this.handleErrorService.handleError<Vacunacion[]>('ConsultaVacunacion', null))
      );
    
  }
 
  registrar(vacunacion:Vacunacion):Observable<Vacunacion>{
    return this.http.post<Vacunacion>(this.baseUrl + 'api/Vacunacion',vacunacion).pipe(tap(_=> this.handleErrorService.log('Datos enviados')),
      catchError(this.handleErrorService.handleError<Vacunacion>('Vacunacion Registrada',null)));
  }
 
  buscarIdentificacion(identificacion:string):Observable<Vacunacion>
  {
    return this.http.get<Vacunacion>(this.baseUrl + 'api/Persona/' + identificacion).pipe(
      catchError(this.handleErrorService.handleError<Vacunacion>('Consulta identificacion', null))
    );
  }
}
 
