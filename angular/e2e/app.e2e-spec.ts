import { SitesTemplatePage } from './app.po';

describe('Sites App', function() {
  let page: SitesTemplatePage;

  beforeEach(() => {
    page = new SitesTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
