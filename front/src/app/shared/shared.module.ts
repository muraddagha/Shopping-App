import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ProductCardComponent } from './components/product-card/product-card.component';
import { DiscoverButtonComponent } from './components/discover-button/discover-button.component';



@NgModule({
  declarations: [
    ProductCardComponent,
    DiscoverButtonComponent
  ],
  imports: [
    CommonModule
  ],
  exports: [
    ProductCardComponent,
    DiscoverButtonComponent
  ]
})
export class SharedModule { }
