import { Component } from '@angular/core';
import { CharacterService } from '../../services/character.service';
import { Character, Characters } from '../../../types';
import { CharacterComponent } from '../../../components/character/character.component';
import { CommonModule } from '@angular/common';
import { PaginatorModule } from 'primeng/paginator';

@Component({
    selector: 'app-home',
    standalone: true,
    templateUrl: './home.component.html',
    styleUrl: './home.component.scss',
    imports: [CharacterComponent, CommonModule, PaginatorModule],
})
export class HomeComponent {
    constructor(private charactersService: CharacterService) {}

    characters: Character[] = [];
    totalItems: number = 0;
    rows: number = 5;

    onCharacterOutput(character: Character) {
        console.log(character, 'output');
    }

    onPageChange(event: any) {
        this.fetchCharacters(event.page + 1, event.rows);
    }

    fetchCharacters(page: number, perPage: number) {
        this.charactersService
            .getCharacters('http://localhost:9000/api/v1/characters', {
                page,
                perPage,
            })
            .subscribe((chars: Characters) => {
                this.characters = chars.items;
                this.totalItems = chars.totalItems;
            });
    }

    ngOnInit() {
        this.fetchCharacters(1, this.rows);
    }
}
