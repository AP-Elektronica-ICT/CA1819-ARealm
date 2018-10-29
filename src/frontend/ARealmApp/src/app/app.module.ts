import { HttpClientModule } from '@angular/common/http';
import { BrowserModule } from '@angular/platform-browser';
import { ErrorHandler, NgModule } from '@angular/core';
import { IonicApp, IonicErrorHandler, IonicModule } from 'ionic-angular';
import { SplashScreen } from '@ionic-native/splash-screen';
import { StatusBar } from '@ionic-native/status-bar';
import { HttpModule } from '@angular/http';
import { MyApp } from './app.component';

//Services: to add a new Service for communication with API, add in declaration and providers!
import { TaskService } from '../services/task.service';
import { PhotoService } from '../services/photo.service';

//Pages: to add a new page, add in declarations and entryComponents!
import { RegistrationPage } from '../pages/registration/registration';
import { MapPage } from '../pages/map/map';
import { PuzzleTaskPage } from '../pages/puzzle-task/puzzle-task';
import {PhotoTaskPage} from '../pages/photo-task/photo-task';
import { SetupPage } from '../pages/setup/setup';


@NgModule({
  declarations: [
    MyApp,
    RegistrationPage,
    MapPage,
    PhotoTaskPage,
    PuzzleTaskPage,
    SetupPage
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    IonicModule.forRoot(MyApp)
  ],
  bootstrap: [IonicApp],
  entryComponents: [
    MyApp,
    RegistrationPage,
    MapPage,
    PhotoTaskPage,
    PuzzleTaskPage,
    SetupPage
  ],
  providers: [
    StatusBar,
    SplashScreen,
    TaskService,
    PhotoService,
    {provide: ErrorHandler, useClass: IonicErrorHandler}
  ]
})
export class AppModule {}
