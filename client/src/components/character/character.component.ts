import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Character } from '../../types';
import { RatingModule } from 'primeng/rating';
import { FormsModule } from '@angular/forms';

@Component({
    selector: 'app-character',
    standalone: true,
    templateUrl: './character.component.html',
    imports: [RatingModule, FormsModule],
    styleUrl: './character.component.scss',
})
export class CharacterComponent {
    @Input() character!: Character;
    @Output() characterOutput: EventEmitter<Character> =
        new EventEmitter<Character>();

    ngOnInit() {
        this.characterOutput.emit(this.character);
    }
}
