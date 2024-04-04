import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';

interface Pass {
  name: string;
  description: string;
  price: number;
}

@Component({
  selector: 'app-passes',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './passes.component.html',
  styleUrl: './passes.component.scss',
})
export class PassesComponent {
  passes: Pass[] = [
    {
      name: 'Basic Pass',
      description:
        'You can enter the gym (you can use equipment, shower, changing room)',
      price: 50,
    },
    {
      name: 'Bronze Pass',
      description: 'You can enter the gym and use the sauna',
      price: 70,
    },
    {
      name: 'Silver Pass',
      description:
        'You can enter the gym, use sauna, and one coffee included each day',
      price: 80,
    },
    {
      name: 'Gold Pass',
      description:
        'You can enter the gym, use sauna, one coffee included each day, and have a 10% discount on buying things in the shop',
      price: 100,
    },
  ];

  selectedPass: Pass | null = null;

  selectPass(pass: Pass) {
    this.selectedPass = pass;
  }
}
