import { SetCompanyModule } from './set-company.module';

describe('SetCompanyModule', () => {
  let setCompanyModule: SetCompanyModule;

  beforeEach(() => {
    setCompanyModule = new SetCompanyModule();
  });

  it('should create an instance', () => {
    expect(setCompanyModule).toBeTruthy();
  });
});
