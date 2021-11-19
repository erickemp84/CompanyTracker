
export interface AppUser {
    id: string;
    firstName: string;
    lastName: string;
    email: string;
    crews?: any;
    userName?: any;
    normalizedUserName?: any;
    normalizedEmail?: any;
    emailConfirmed: boolean;
    passwordHash?: any;
    securityStamp?: any;
    concurrencyStamp?: any;
    phoneNumber?: any;
    phoneNumberConfirmed: boolean;
    twoFactorEnabled: boolean;
    lockoutEnd?: any;
    lockoutEnabled: boolean;
    accessFailedCount: number;
}
