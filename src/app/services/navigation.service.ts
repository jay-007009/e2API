import { Book } from './../models/models';
import {
  Category,
  Order,
  Payment,
  PaymentMethod,
  User,
} from '../models/models';
import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { map } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class NavigationService {
  baseurl = 'https://localhost:7262/api/Shopping/';

  constructor(private http: HttpClient) {}

  getCategoryList() {
    let url = this.baseurl + 'GetCategoryList';
    return this.http.get<any[]>(url).pipe(
      map((categories) =>
        categories.map((category) => {
          let mappedCategory: Category = {
            id: category.id,
            category: category.category,
            subCategory: category.subCategory,
          };
          return mappedCategory;
        })
      )
    );
  }

  getBooks(category: string, subCategory: string, count: number) {
    return this.http.get<any[]>(this.baseurl + 'GetBooks', {
      params: new HttpParams()
        .set('category', category)
        .set('subCategory', subCategory)
        .set('count', count),
    });
  }

  getBook(id: number) {
    let url = this.baseurl + 'GetBook/' + id;
    return this.http.get(url);
  }

  registerUser(user: User) {
    let url = this.baseurl + 'RegisterUser';
    return this.http.post(url, user, { responseType: 'text' });
  }

  loginUser(email: string, password: string) {
    let url = this.baseurl + 'LoginUser';
    return this.http.post(
      url,
      { Email: email, Password: password },
      { responseType: 'text' }
    );
  }

  submitReview(userid: number, bookid: number, review: string) {
    let obj: any = {
      User: {
        Id: userid,
      },
      Book: {
        Id: bookid,
      },
      Value: review,
    };

    let url = this.baseurl + 'InsertReview';
    return this.http.post(url, obj, { responseType: 'text' });
  }

  getAllReviewsOfBook(bookId: number) {
    let url = this.baseurl + 'GetBookReviews/' + bookId;
    return this.http.get(url);
  }

  addToCart(userid: number, bookid: number) {
    let url = this.baseurl + 'InsertCartItem/' + userid + '/' + bookid;
    return this.http.post(url, null, { responseType: 'text' });
  }

  getActiveCartOfUser(userid: number) {
    let url = this.baseurl + 'GetActiveCartOfUser/' + userid;
    return this.http.get(url);
  }

  getAllPreviousCarts(userid: number) {
    let url = this.baseurl + 'GetAllPreviousCartsOfUser/' + userid;
    return this.http.get(url);
  }

  getPaymentMethods() {
    let url = this.baseurl + 'GetPaymentMethods';
    return this.http.get<PaymentMethod[]>(url);
  }

  insertPayment(payment: Payment) {
    return this.http.post(this.baseurl + 'InsertPayment', payment, {
      responseType: 'text',
    });
  }

  insertOrder(order: Order) {
    return this.http.post(this.baseurl + 'InsertOrder', order);
  }
}
