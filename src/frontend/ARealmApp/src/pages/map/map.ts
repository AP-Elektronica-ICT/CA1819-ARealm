import { Component, ElementRef, ViewChild } from '@angular/core';
import { IonicPage, NavController, NavParams } from 'ionic-angular';
import { SetupPage } from '../setup/setup';
import { PuzzleTaskPage } from '../puzzle-task/puzzle-task';
import { RegistrationPage } from '../registration/registration';
import { App, MenuController } from 'ionic-angular';
import {Platform} from "ionic-angular";
import {GoogleMaps, GoogleMap, LatLng, GoogleMapsEvent} from '@ionic-native/google-maps';

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

  @ViewChild('map')
  private mapElement:ElementRef;
  private map:GoogleMap;
  private location:LatLng;
  private locations:Array<any> = [];
  activeMenu: string;

  constructor(public navCtrl: NavController, public navParams: NavParams, menu: MenuController, private platform: Platform, private googleMaps: GoogleMaps) {
      this.location = new LatLng(42.346903, -71.135101);
      menu.enable(true);

      this.locations.push({position: {lat: 42.346903, lng: -71.135101}});
      this.locations.push({position: {lat: 42.342525, lng: -71.145943}});
      this.locations.push({position: {lat: 42.345792, lng: -71.138167}});
      this.locations.push({position: {lat: 42.320684, lng: -71.182951}});
      this.locations.push({position: {lat: 42.359076, lng: -71.0645484}});
      this.locations.push({position: {lat: 42.36, lng: -71.1}});
    }
  
  

  ionViewDidLoad() {
    console.log('ionViewDidLoad MapPage');
    this.platform.ready().then(() => {
      let element = this.mapElement.nativeElement;
      this.map = this.googleMaps.create(element);

      this.map.one(GoogleMapsEvent.MAP_READY).then(() => {
        let options = {
          target: this.location,
          zoom: 8
        };

        this.map.moveCamera(options);
        setTimeout(() => {this.addMarker()}, 2000);
      });
    });
  }
  addMarker() {
    this.map.addMarker({
      title: 'My Marker',
      icon: 'blue',
      animation: 'DROP',
      position: {
        lat: this.location.lat,
        lng: this.location.lng
      }
    })
    .then(marker => {
      marker.on(GoogleMapsEvent.MARKER_CLICK).subscribe(() => {
        alert('Marker Clicked');
      });
    });
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
