import { Injectable } from '@angular/core';
import { JwtHelperService } from '@auth0/angular-jwt';
import { Subject, window } from 'rxjs';
import { Cart, Payment, Book, User } from '../models/models';
import { NavigationService } from './navigation.service';
import { ToastrService } from 'ngx-toastr';
@Injectable({
  providedIn: 'root'
})
export class UtilityService {
  changeCart = new Subject(); //subject is same as observable 

  constructor(
    private toastr: ToastrService,
    private navigationService: NavigationService,
    private jwt: JwtHelperService
  ) {}

  applyDiscount(price: number, discount: number): number {
    let finalPrice: number = price - price * (discount / 100);
    return finalPrice;
  }

 
  getUser(): User {
    let token = this.jwt.decodeToken();
    let user: User = {
      id: token.id,
      firstName: token.firstName,
      lastName: token.lastName,
      address: token.address,
      mobile: token.mobile,
      email: token.email,
      password: '',
      createdAt: token.createdAt,
      modifiedAt: token.modifiedAt,
    };
    return user;
  }

  setUser(token: string) {
    localStorage.setItem('user', token);
  }

  isLoggedIn() {
    return localStorage.getItem('user') ? true : false;
  }

  logoutUser() {
    localStorage.removeItem('user');
  }

  addToCart(book: Book) {
    debugger;
    let bookid = book.id;
    let userid = this.getUser().id;

    this.navigationService.addToCart(userid, bookid).subscribe((res) => {
      this.showSuccess() ;
      if (res.toString() === 'inserted.') this.changeCart.next(1); //change register
    });
  }

  calculatePayment(cart: Cart, payment: Payment) {
    payment.totalAmount = 0;
    payment.amountPaid = 0;
    payment.amountReduced = 0;

    for (let cartitem of cart.cartItems) {
      payment.totalAmount += cartitem.book.price;

      payment.amountReduced +=
        cartitem.book.price -
        this.applyDiscount(
          cartitem.book.price,
          cartitem.book.offer.discount
        );

      payment.amountPaid += this.applyDiscount(
        cartitem.book.price,
        cartitem.book.offer.discount
      );
    }

    if (payment.amountPaid > 50000) payment.shipingCharges = 500; //change
    else if (payment.amountPaid > 20000) payment.shipingCharges = 200;
    else if (payment.amountPaid > 5000) payment.shipingCharges = 100;
    else payment.shipingCharges = 50;
  }

  calculatePricePaid(cart: Cart) {
    let pricepaid = 0;
    for (let cartitem of cart.cartItems) {
      pricepaid += this.applyDiscount(
        cartitem.book.price,
        cartitem.book.offer.discount
      );
    }
    return pricepaid;
  }

  orderTheCart() {
    
  }
  showSuccess() {
    this.toastr.success('Hello world!', 'Toastr fun!');
  }

  
}
