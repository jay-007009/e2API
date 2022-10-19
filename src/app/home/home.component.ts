import { SuggestedBook } from '../models/models';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  suggestedBook: SuggestedBook[] = [
    {
      banerimage:'25.jpg',
        category:{
          id:1,
          category:'book',
          subCategory:'Adventure'
        },
    },

    {
      banerimage:'52.jpg',
        category:{
          id:1,
          category:'book',
          subCategory:'Biography'
        },
    },

    {
      banerimage:'58.jpg',
        category:{
          id:1,
          category:'book',
          subCategory:'Fiction'
        },
    },

    {
      banerimage:'85.jpg',
        category:{
          id:1,
          category:'book',
          subCategory:'Art'
        },
    },
  ];
  constructor() { }

  ngOnInit(): void {
  }

}
