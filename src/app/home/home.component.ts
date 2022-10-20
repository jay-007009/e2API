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
      banerimage:'2.jpg',
        category:{
          id:1,
          category:'book',
          subCategory:'Adventure'
        },
        subCategory:{
          id:1,
          category:'book',
          subCategory:'Adventure'
        }
    },

    {
      banerimage:'36.jpg',
        category:{
          id:1,
          category:'book',
          subCategory:'Biography'
        },
        subCategory:{
          id:1,
          category:'book',
          subCategory:'Adventure'
        }
    },

    {
      banerimage:'56.jpg',
        category:{
          id:1,
          category:'book',
          subCategory:'Fiction'
        },
        subCategory:{
          id:1,
          category:'book',
          subCategory:'Adventure'
        }
    },

    {
      banerimage:'63.jpg',
        category:{
          id:1,
          category:'book',
          subCategory:'Art'
        },
        subCategory:{
          id:1,
          category:'book',
          subCategory:'Adventure'
        }
    },
  ];
  constructor() { }

  ngOnInit(): void {
  }

}
