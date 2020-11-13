import { TestBed } from '@angular/core/testing';

import { VacunacionService } from './vacunacion.service';

describe('VacunacionService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: VacunacionService = TestBed.get(VacunacionService);
    expect(service).toBeTruthy();
  });
});
