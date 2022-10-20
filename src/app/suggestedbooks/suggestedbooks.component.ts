import { Category, Book } from '../models/models';
import { NavigationService } from '../services/navigation.service';
import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-suggestedbooks',
  templateUrl: './suggestedbooks.component.html',
  styleUrls: ['./suggestedbooks.component.css']
})
export class SuggestedbooksComponent implements OnInit {

  @Input() category: Category = {
    id: 0,
    category: '',
    subCategory: '',
  };

  @Input() subCategory: Category = {
    id: 0,
    category: '',
    subCategory: '',
  };

  @Input() count: number = 3;
  books: Book[] = [];

  constructor(private navigationService: NavigationService) {}

  ngOnInit(): void {
    this.navigationService
    .getBooks(
      this.category.category,
      this.category.subCategory,
      this.count
    )
    .subscribe((res: any[]) => {
      for (let book of res) {
        this.books.push(book);
      }
    });
  }

}
