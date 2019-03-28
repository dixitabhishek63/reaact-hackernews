import { Shertech001TemplatePage } from './app.po';

describe('Shertech001 App', function() {
  let page: Shertech001TemplatePage;

  beforeEach(() => {
    page = new Shertech001TemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
