import { ITaskValidation } from './task.service';
import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
@Injectable()
export class PhotoService {

  constructor(private http: HttpClient) { }

  url : string = 'http://localhost:5000/api/validatephoto'
  httpOptions = {
     headers: new HttpHeaders({
       'Content-Type':  'application/json'
    
     })
   }
    public SendPhotoForValidation(photo:Object):Observable<IPhotoValidation> {
        return this.http.post<IPhotoValidation>(this.url,photo,this.httpOptions)
    }

}

export interface IPhoto
{
    Content: string; // Base64 encoded picture
}
export interface IPhotoValidation
{
    isCorrect: boolean;
}