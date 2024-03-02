import { Injectable } from '@angular/core';
import { ApiService } from './api.service';
import { Observable } from 'rxjs';
import { Characters, PaginationParams } from '../../types';

@Injectable({
  providedIn: 'root'
})
export class CharacterService {

  constructor(
    private apiService: ApiService
  ) { }

  getCharacters = (url: string, params: PaginationParams): Observable<Characters> => {
    return this.apiService.get(url, {
        params,
        responseType: 'json'
    });
  }
}
