import { Component } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { SetupPage } from '../setup/setup';
import { PuzzleTaskPage } from '../puzzle-task/puzzle-task';
import { RegistrationPage } from '../registration/registration';
import { App, MenuController } from 'ionic-angular';

/**
 * Generated class for the MapPage page.
 *
 * See https://ionicframework.com/docs/components/#navigation for more info on
 * Ionic pages and navigation.
 */

@IonicPage()
@Component({
  selector: 'page-map',
  templateUrl: 'map.html',
})
export class MapPage {

  activeMenu: string;

  constructor(public navCtrl: NavController, public navParams: NavParams, menu: MenuController) {
    menu.enable(true);
  }

  ionViewDidLoad() {
    console.log('ionViewDidLoad MapPage');
  }
  gotoSetup(){
    this.navCtrl.push(SetupPage);
  }

  gotoRegistration(){
    this.navCtrl.push(RegistrationPage);
  }
  gotoPuzzleTask(){
    this.navCtrl.push(PuzzleTaskPage);
  }

}
