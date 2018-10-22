import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { PictureTaskPage } from './picture-task';

@NgModule({
  declarations: [
    PictureTaskPage,
  ],
  imports: [
    IonicPageModule.forChild(PictureTaskPage),
  ],
})
export class PictureTaskPageModule {}
