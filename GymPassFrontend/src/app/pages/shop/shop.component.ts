import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';

interface ShopItem {
  name: string;
  description: string;
  imageUrl: string;
  price: number;
}

@Component({
  selector: 'app-shop',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './shop.component.html',
  styleUrl: './shop.component.scss',
})
export class ShopComponent {
  shopItems: ShopItem[] = [
    {
      name: 'Item 1',
      description: 'Description of item 1',
      imageUrl: '../../../favicon.ico',
      price: 10.99,
    },
    {
      name: 'Item 2',
      description: 'Description of item 2',
      imageUrl: '../../../favicon.ico',
      price: 15.99,
    },
    {
      name: 'Item 3',
      description: 'Description of item 3',
      imageUrl: '../../../favicon.ico',
      price: 8.99,
    },
    {
      name: 'Item 4',
      description: 'Description of item 4',
      imageUrl: '../../../favicon.ico',
      price: 12.99,
    },
    {
      name: 'Item 5',
      description: 'Description of item 5',
      imageUrl: '../../../favicon.ico',
      price: 9.99,
    },
    {
      name: 'Item 6',
      description: 'Description of item 6',
      imageUrl: '../../../favicon.ico',
      price: 14.99,
    },
    {
      name: 'Item 7',
      description: 'Description of item 7',
      imageUrl: '../../../favicon.ico',
      price: 11.99,
    },
    {
      name: 'Item 8',
      description: 'Description of item 8',
      imageUrl: '../../../favicon.ico',
      price: 16.99,
    },
    {
      name: 'Item 9',
      description: 'Description of item 9',
      imageUrl: '../../../favicon.ico',
      price: 7.99,
    },
    {
      name: 'Item 10',
      description: 'Description of item 10',
      imageUrl: '../../../favicon.ico',
      price: 13.99,
    },
    {
      name: 'Item 11',
      description: 'Description of item 11',
      imageUrl: '../../../favicon.ico',
      price: 10.99,
    },
    {
      name: 'Item 12',
      description: 'Description of item 12',
      imageUrl: '../../../favicon.ico',
      price: 15.99,
    },
    {
      name: 'Item 13',
      description: 'Description of item 13',
      imageUrl: '../../../favicon.ico',
      price: 8.99,
    },
    {
      name: 'Item 14',
      description: 'Description of item 14',
      imageUrl: '../../../favicon.ico',
      price: 12.99,
    },
    {
      name: 'Item 15',
      description: 'Description of item 15',
      imageUrl: '../../../favicon.ico',
      price: 9.99,
    },
    {
      name: 'Item 16',
      description: 'Description of item 16',
      imageUrl: '../../../favicon.ico',
      price: 14.99,
    },
    {
      name: 'Item 17',
      description: 'Description of item 17',
      imageUrl: '../../../favicon.ico',
      price: 11.99,
    },
    {
      name: 'Item 18',
      description: 'Description of item 18',
      imageUrl: '../../../favicon.ico',
      price: 16.99,
    },
    {
      name: 'Item 19',
      description: 'Description of item 19',
      imageUrl: '../../../favicon.ico',
      price: 7.99,
    },
    {
      name: 'Item 20',
      description: 'Description of item 20',
      imageUrl: '../../../favicon.ico',
      price: 13.99,
    },
  ];

  addToCart(item: ShopItem) {
    // Logic to add item to cart
    console.log('Added to cart:', item);
  }
}
