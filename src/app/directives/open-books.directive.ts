import { Directive, HostListener, Input } from '@angular/core';
import { Router } from '@angular/router';
import { Category } from '../models/models';

@Directive({
  selector: '[OpenBooks]'
})
export class OpenBooksDirective {
  @Input() category: Category = {
    id: 0,
    category: '',
    subCategory: '',
  };

  @HostListener('click') OpenBooks() {
    this.router.navigate(['/books'], {
      queryParams: {
        category: this.category.category,
        subCategory: this.category.subCategory,
      },
    });
  }

  constructor(private router: Router) {}

}
