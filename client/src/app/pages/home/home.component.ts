import { Component } from '@angular/core';
import { CharacterService } from '../../services/character.service';
import { Characters } from '../../../types';

@Component({
    selector: 'app-home',
    standalone: true,
    imports: [],
    templateUrl: './home.component.html',
    styleUrl: './home.component.scss',
})
export class HomeComponent {
    constructor(private charactersService: CharacterService) {}

    ngOnInit() {
        this.charactersService
            .getCharacters('http://localhost:9000/api/v1/characters', {
                page: 1,
                perPage: 10,
            })
            .subscribe((chars: Characters) => {
                console.log(chars.items);
            });
    }
}
