import { BrowserModule } from '@angular/platform-browser';
import { ErrorHandler, NgModule } from '@angular/core';
import { IonicApp, IonicErrorHandler, IonicModule } from 'ionic-angular';
import { SplashScreen } from '@ionic-native/splash-screen';
import { StatusBar } from '@ionic-native/status-bar';

import { MyApp } from './app.component';

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
    {provide: ErrorHandler, useClass: IonicErrorHandler}
  ]
})
export class AppModule {}
