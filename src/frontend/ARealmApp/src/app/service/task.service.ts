import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';

@Injectable()
export class TaskService {

  constructor(private http: HttpClient) { }

    /**
     * SendAnswerForValidation: PUT voor het antwoord te versturen naar de server
     */
    public SendAnswerForValidation(answer: string) {
        return this.http.put<>
    }


}

export interface ITask
{
    Id: number;
    Title: string;
    Description: string;
    District: IDistrict;
    DistrictID: number;
}
export interface IDistrict
{

    Id: number;
    Task: ITask;
    CurrentStateString: string;

}
