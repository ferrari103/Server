import { Injectable } from '@angular/core';
import { HttpClient} from '@angular/common/http';
import { Event } from './shared/product';

@Injectable()
export class DataService {

  private url = "/api/events";

  constructor(private http: HttpClient) {
  }

  getProducts() {
    return this.http.get(this.url);
  }

  getProduct(id: number) {
    return this.http.get(this.url + '/' + id);
  }

  createProduct(product: Event) {
    return this.http.post(this.url, product);
  }
  updateProduct(product: Event) {

    return this.http.put(this.url, product);
  }
  deleteProduct(id: number) {
    return this.http.delete(this.url + '/' + id);
  }
}
