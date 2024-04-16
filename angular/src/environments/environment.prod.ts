import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'BSG1',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44312/',
    redirectUri: baseUrl,
    clientId: 'BSG1_App',
    responseType: 'code',
    scope: 'offline_access BSG1',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44375',
      rootNamespace: 'BSG1',
    },
  },
} as Environment;
