import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';

import {
  MatToolbarModule,
  MatSidenavModule,
  MatListModule,
  MatSnackBarModule,
  MatIconModule
} from '@angular/material';

import { TopNavComponent } from './components/shared/topnav/topnav.component';

import { GatewayService } from './services/shared/gateway.service';
import { JWTGatewayService } from './services/shared/jwtgateway.service';
import { SnackbarService } from './services/shared/snackbar.service';
import { LoggingService } from './services/shared/logging.service';

@NgModule({
  declarations: [
    TopNavComponent
  ],
  imports: [
    CommonModule,
    HttpClientModule,
    MatToolbarModule,
    MatSidenavModule,
    MatListModule,
    MatSnackBarModule,
    MatIconModule
  ],
  exports: [
    TopNavComponent
  ],
  providers: [
    GatewayService,
    JWTGatewayService,
    SnackbarService,
    LoggingService
  ],
  bootstrap: [

  ]
})
export class SharedModule { }
