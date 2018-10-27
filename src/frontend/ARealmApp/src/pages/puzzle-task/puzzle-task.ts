import { Component, OnInit } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { IPuzzleTask, TaskService } from '../../app/service/task.service';

/**
 * Generated class for the PuzzleTaskPage page.
 *
 * See https://ionicframework.com/docs/components/#navigation for more info on
 * Ionic pages and navigation.
 */

@IonicPage()
@Component({
  selector: 'page-puzzle-task',
  templateUrl: 'puzzle-task.html',
})
export class PuzzleTaskPage {

  PuzzleTask : IPuzzleTask;
  answer: string="";
  Id:number;
  CorrectAnswer:boolean;
  constructor(public navCtrl: NavController, public navParams: NavParams, public tasksvc: TaskService) {
  }

  ionViewDidLoad() {
    this.Id=this.navParams.get("id")
    console.log("Id:"+this.Id);

    this.tasksvc.GetPuzzleTask(this.Id).subscribe(puzzletask=> 
      {
        this.PuzzleTask = puzzletask;
        console.log('Question:'+this.PuzzleTask.question)

      })
  }

  Send(){
    this.PuzzleTask.answer = this.answer;
    this.tasksvc.SendAnswerForValidation(this.PuzzleTask).subscribe(d =>
      {
        this.CorrectAnswer = d.isCorrect;
      })
  }
}
