import { Injectable } from '@angular/core';
import { ApiService } from './api.service';
import { Observable } from 'rxjs';
import { Character, Characters, PaginationParams } from '../../types';

@Injectable({
    providedIn: 'root',
})
export class CharacterService {
    constructor(private apiService: ApiService) {}

    getCharacters = (
        url: string,
        params: PaginationParams
    ): Observable<Characters> => {
        return this.apiService.get(url, {
            params,
            responseType: 'json',
        });
    };

    createCharacter = (url: string, body: Character): Observable<any> => {
        return this.apiService.post(url, body, {});
    };

    updateCharacter = (url: string, body: Character): Observable<any> => {
        return this.apiService.put(url, body, {});
    };

    deleteCharacter = (url: string): Observable<any> => {
        return this.apiService.delete(url, {});
    };
}
