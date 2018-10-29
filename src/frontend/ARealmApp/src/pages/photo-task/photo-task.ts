//import { ITaskValidation } from './../../app/service/task.service';
import { PhotoService, IPhoto, IPhotoValidation } from './../../services/photo.service';
import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';


/**
 * Generated class for the PhotoTask page.
 *
 * See https://ionicframework.com/docs/components/#navigation for more info on
 * Ionic pages and navigation.
 */

@IonicPage()
@Component({
  selector: 'page-photo-task',
  templateUrl: 'photo-task.html',
})
export class PhotoTaskPage {

  photo: Object;
  response:IPhotoValidation;

  constructor(public navCtrl: NavController, public navParams: NavParams,private _service:PhotoService) {
  
  }

  ionViewDidLoad() {
    console.log('ionViewDidLoad PhotoTaskPage');
  }

  public sendPhotoForValidation(){
    this.photo = {
      "content": "image data Base64 encoded"
    }
    this._service.SendPhotoForValidation(this.photo)
    .subscribe(d => this.response = d);
  }

}
