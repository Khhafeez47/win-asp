import { win-asp-core-iisTemplatePage } from './app.po';

describe('win-asp-core-iis App', function() {
  let page: win-asp-core-iisTemplatePage;

  beforeEach(() => {
    page = new win-asp-core-iisTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
