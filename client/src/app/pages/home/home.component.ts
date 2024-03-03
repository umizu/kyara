import { Component } from '@angular/core';
import { CharacterService } from '../../services/character.service';
import { Character, Characters } from '../../../types';
import { CharacterComponent } from '../../../components/character/character.component';
import { CommonModule } from '@angular/common';

@Component({
    selector: 'app-home',
    standalone: true,
    templateUrl: './home.component.html',
    styleUrl: './home.component.scss',
    imports: [CharacterComponent, CommonModule],
})
export class HomeComponent {
    constructor(private charactersService: CharacterService) {}

    characters: Character[] = [];

    onCharacterOutput(character: Character) {
        console.log(character, 'output');

    }
    ngOnInit() {
        this.charactersService
            .getCharacters('http://localhost:9000/api/v1/characters', {
                page: 1,
                perPage: 14,
            })
            .subscribe((chars: Characters) => {
                this.characters = chars.items;
            });
    }
}
