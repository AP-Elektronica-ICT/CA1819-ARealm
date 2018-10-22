import { NgModule } from '@angular/core';
import { IonicPageModule } from 'ionic-angular';
import { PuzzleTaskPage } from './puzzle-task';

@NgModule({
  declarations: [
    PuzzleTaskPage,
  ],
  imports: [
    IonicPageModule.forChild(PuzzleTaskPage),
  ],
})
export class PuzzleTaskPageModule {}
