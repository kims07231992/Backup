﻿import { Component, Input } from '@angular/core';
import { SideNavComponent } from '../sidenav/sidenav.component'
import { UserService } from '../../services/user.service';

@Component({
    selector: 'app-topnav',
    templateUrl: './topnav.component.html',
    styleUrls: ['./topnav.component.scss', './_topnav-theme.scss']
})
export class TopNavComponent {
    
    constructor(private userService: UserService) {
    }

    logout() {
        this.userService.signOut();
    }

    signOut() {
        this.userService.signOut();
    }
}
