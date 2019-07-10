import { RaymondYuSolutionTemplatePage } from './app.po';

describe('RaymondYuSolution App', function() {
  let page: RaymondYuSolutionTemplatePage;

  beforeEach(() => {
    page = new RaymondYuSolutionTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
