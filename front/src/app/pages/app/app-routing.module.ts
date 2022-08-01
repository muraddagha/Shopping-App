import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';

const routes: Routes = [
  {
    path: '',
    component: AppComponent,
    children: [
      {
        path: "", loadChildren:() => import("./modules/home/home.module").then(m => m.HomeModule)
      },
      {
        path: "about", loadChildren:() => import("./modules/about/about.module").then(m => m.AboutModule)

      },
      {
        path: "contact", loadChildren:() => import("./modules/contact/contact.module").then(m => m.ContactModule)

      },
      {
        path: "product", loadChildren:() => import("./modules/product-detail/product-detail.module").then(m => m.ProductDetailModule)
      }
    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
