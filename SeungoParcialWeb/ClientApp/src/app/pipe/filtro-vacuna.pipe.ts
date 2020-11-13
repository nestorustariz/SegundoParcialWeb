import { Pipe, PipeTransform } from '@angular/core';
import { Vacunacion } from '../models/vacunacions';

@Pipe({
  name: 'filtroVacuna'
})
export class FiltroVacunaPipe implements PipeTransform {

  transform(vacunas: Vacunacion[],  searchText: string): any {
    if (searchText === undefined || searchText === '') return vacunas;
      return vacunas.filter(p =>
      p.tipoVacuna.toLowerCase()
    .indexOf(searchText.toLowerCase()) !== -1);
    }

    

}
