import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { PhotoTaskPage } from './photo-task';

@NgModule({
  declarations: [
    PhotoTaskPage,
  ],
  imports: [
    IonicPageModule.forChild(PhotoTaskPage),
  ],
})
export class PuzzleTaskPageModule {}
