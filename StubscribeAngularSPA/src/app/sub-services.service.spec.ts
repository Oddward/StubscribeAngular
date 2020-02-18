import { TestBed } from '@angular/core/testing';

import { SubServicesService } from './sub-services.service';

describe('SubServicesService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: SubServicesService = TestBed.get(SubServicesService);
    expect(service).toBeTruthy();
  });
});
