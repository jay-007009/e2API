import { Component, Input, OnInit } from '@angular/core';
import { Book } from '../models/models';
import { UtilityService } from '../services/utility.service';
@Component({
  selector: 'app-book',
  templateUrl: './book.component.html',
  styleUrls: ['./book.component.css']
})
export class BookComponent implements OnInit {
  @Input() view: 'grid' | 'list' | 'currcartitem' | 'prevcartitem' = 'grid';
  @Input() book: Book = {
    id: 0,
    title: '',
    description: '',
    price: 0,
    quantity: 0,
    bookCategory: {
      id: 1,
      category: '',
      subCategory: '',
    },
    offer: {
      id: 1,
      title: '',
      discount: 0,
    },
    imageName: '',
  };

  constructor(public utilityService: UtilityService) {}

  ngOnInit(): void {}

}
