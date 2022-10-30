
import { NavigationService } from './../services/navigation.service';


export interface SuggestedBook {
    banerimage: string;
    category: Category;
   // subCategory:Category;
  }

  export interface NavigationItem {
    category: string;
    subcategories: string[];
  }

  export interface User {
    id: number;
    firstName: string;
    lastName: string;
    email: string;
    address: string;
    mobile: string;
    password: string;
    createdAt: string;
    modifiedAt: string;
  }



  export interface Offer {
    id: number;
    title: string;
    discount: number;
  }

  export interface Category {
    id: number;
    category: string;
    subCategory: string;
  }

  export interface Book {
    id: number;
    title: string;
    description: string;
    bookCategory: Category;
    offer: Offer;
    price: number;
    quantity: number;
    imageName: string;
  }

  export interface Review {
    id: number;
    user: User;
    book: Book;
    value: string;
    createdAt: string;
  }

  // #endregion

  // #region Cart

  export interface CartItem {
    id: number;
    book: Book;
  }

  export interface Cart {
    id: number;
    user: User;
    cartItems: CartItem[];
    ordered: boolean;
    orderedOn: string;
  }

  // #endregion

  // #region Payment and Orders

  export interface PaymentMethod {
    id: number;
    type: string;
    provider: string;
    available: boolean;
    reason: string;
  }

  export interface Payment {
    id: number;
    user: User;
    paymentMethod: PaymentMethod;
    totalAmount: number;
    shipingCharges: number;
    amountReduced: number;
    amountPaid: number;
    createdAt: string;
  }

  export interface Order {
    id: number;
    user: User;
    cart: Cart;
    payment: Payment;
    createdAt: string;
  }

  // #endregion
