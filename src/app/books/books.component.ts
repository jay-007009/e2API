import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Book } from '../models/models';
import { NavigationService } from '../services/navigation.service';
import { UtilityService } from '../services/utility.service';
@Component({
  selector: 'app-books',
  templateUrl: './books.component.html',
  styleUrls: ['./books.component.css']
})
export class BooksComponent implements OnInit {

  view: 'grid' | 'list' = 'grid';
  sortby: 'default' | 'htl' | 'lth' = 'default';
  books: Book[] = [];

  constructor(
    private activatedRoute: ActivatedRoute,
    private navigationService: NavigationService,
    private utilityService: UtilityService
  ) {}

  ngOnInit(): void {
    this.activatedRoute.queryParams.subscribe((params: any) => {
      let category = params.category;
      let subCategory = params.subCategory;

      if (category && subCategory)
        this.navigationService
          .getBooks(category, subCategory, 5) //ahiyathi book nu badlay
          .subscribe((res: any) => {
            this.books = res;
          });
    });
  }

  // sortByPrice(sortKey: string) {
  //   this.books.sort((a, b) => {
  //     if (sortKey === 'default') {
  //       return a.id > b.id ? 1 : -1;
  //     }
  //     return (
  //       (sortKey === 'htl' ? 1 : -1) *
  //       (this.utilityService.applyDiscount(a.price, a.offer.discount) > //a greater hoi to -1 display krvanu high to low sort ma
  //       this.utilityService.applyDiscount(b.price, b.offer.discount)
  //         ? -1
  //         : 1)
  //     );
  //   });
  // }

  sortByPrice(sortKey:string){
    this.books.sort((a,b)=>{
      if(sortKey==='default'){ //id pramane sort thai data
        return a.id>b.id?1:-1;
      }
      if(sortKey==='htl'){
       return this.utilityService.applyDiscount(a.price,a.offer.discount)>
        this.utilityService.applyDiscount(b.price,b.offer.discount)
        ?-1
        :1
      }
      if(sortKey==='lth'){
       return this.utilityService.applyDiscount(a.price,a.offer.discount)>
        this.utilityService.applyDiscount(b.price,b.offer.discount)
        ?1
        :-1
      }
      return 0;
    });
  }

}
