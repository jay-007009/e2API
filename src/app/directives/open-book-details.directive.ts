import { Directive, HostListener, Input } from '@angular/core';
import { Router } from '@angular/router';

@Directive({
  selector: '[appOpenBookDetails]'
})
export class OpenBookDetailsDirective {

  @Input() bookId: number = 0;
  @HostListener('click') openBookDetails() {
    window.scrollTo(0, 0);
    this.router.navigate(['/book-details'], {
      queryParams: {
        id: this.bookId,
      },
    });
  }
  constructor(private router: Router) {}

}
