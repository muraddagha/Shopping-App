import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ProductDetailRoutingModule } from './product-detail-routing.module';
import { ProductInfoComponent } from './components/product-info/product-info.component';
import { ProductDetailNavComponent } from './components/product-detail-nav/product-detail-nav.component';
import { ProductDetailComponent } from './components/product-detail/product-detail.component';


@NgModule({
  declarations: [
    ProductInfoComponent,
    ProductDetailNavComponent,
    ProductDetailComponent
  ],
  imports: [
    CommonModule,
    ProductDetailRoutingModule
  ]

})
export class ProductDetailModule { }
