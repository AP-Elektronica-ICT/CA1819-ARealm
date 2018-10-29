import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';

@Injectable()
export class TaskService {

  constructor(private http: HttpClient) { }

    /**
     * SendAnswerForValidation: PUT voor het antwoord te versturen naar de server
     * TODO: Frontend styling & testing
     */
    public SendAnswerForValidation(task:ITask) {
        return this.http.put<ITaskValidation>(
            'http://localhost:5000/api/taskvalidation',
            task
            )
    }


}


//If you change these interfaces don't forget to change them in the backend as well!
export interface ITask
{
    Id: number;
    Title: string;
    Description: string;
    District: IDistrict;
    DistrictID: number;
    Answer: string;
}
export interface IDistrict
{
    Id: number;
    Task: ITask;
    CurrentStateString: string;
}
export interface ITaskValidation
{
    IsCorrect: boolean;
}