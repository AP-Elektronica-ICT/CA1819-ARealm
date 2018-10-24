import { BrowserModule } from '@angular/platform-browser';
import { ErrorHandler, NgModule } from '@angular/core';
import { IonicApp, IonicErrorHandler, IonicModule } from 'ionic-angular';
import { SplashScreen } from '@ionic-native/splash-screen';
import { StatusBar } from '@ionic-native/status-bar';

import { MyApp } from './app.component';


//Services: to add a new Service for communication with API, add in declaration and providers!
import { TaskService } from './service/task.service';

//Pages: to add a new page, add in declarations and entryComponents!
import { RegistrationPage } from '../pages/registration/registration';
import { MapPage } from '../pages/map/map';
import { PictureTaskPage } from '../pages/picture-task/picture-task';
import { PuzzleTaskPage } from '../pages/puzzle-task/puzzle-task';
import { SetupPage } from '../pages/setup/setup';


@NgModule({
  declarations: [
    MyApp,
    RegistrationPage,
    MapPage,
    PictureTaskPage,
    PuzzleTaskPage,
    SetupPage
  ],
  imports: [
    BrowserModule,
    IonicModule.forRoot(MyApp)
  ],
  bootstrap: [IonicApp],
  entryComponents: [
    MyApp,
    RegistrationPage,
    MapPage,
    PictureTaskPage,
    PuzzleTaskPage,
    SetupPage
  ],
  providers: [
    StatusBar,
    SplashScreen,
    TaskService,
    {provide: ErrorHandler, useClass: IonicErrorHandler}
  ]
})
export class AppModule {}
